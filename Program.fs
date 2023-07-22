module VipsTest

open NetVips
open System.Threading.Tasks

// https://www.libvips.org/API/current/func-list.html
// TODO: some things need to be changed to use settings.

let createThumbnail fileName =
    // async {
    // https://kleisauke.github.io/net-vips/api/NetVips.Enums.Interesting.html
    // https://www.libvips.org/API/current/VipsForeignSave.html#vips-webpsave
    Image
        // .NewFromFile($"./images/{fileName}", access = Enums.Access.Sequential)
        // Image.Thumbnail performs better: https://github.com/kleisauke/net-vips/issues/97#issuecomment-1646551267
        .Thumbnail($"./images/{fileName}", width = 100, height = 100, crop = Enums.Interesting.Attention)
        .Webpsave($"./output/netvips/rido-thumb-{fileName}.webp", effort = 3, q = 70)
// }

let convertImageToOptimizedFormat fileName =
    // async {
    let image =
        Image.NewFromFile($"./images/{fileName}", access = Enums.Access.Sequential)
    // TODO: this needs to be changed to settings
    // https://www.libvips.org/API/current/VipsForeignSave.html#vips-webpsave
    if image.Width > 1400 then
        // Image.Thumbnail performs better: https://github.com/kleisauke/net-vips/issues/97#issuecomment-1646551267
        Image
            .Thumbnail($"./images/{fileName}", width = 1400)
            .Webpsave($"./output/netvips/rido-optimized-{fileName}.webp", effort = 3, q = 80)
    else
        Image
            .NewFromFile($"./images/{fileName}", access = Enums.Access.Sequential)
            .Webpsave($"./output/netvips/rido-optimized-{fileName}.webp", effort = 3, q = 80)
// }

let convertImageToArchiveFormat fileName =
    // async {
    // https://www.libvips.org/API/current/VipsForeignSave.html#vips-heifsave
    Image
        .NewFromFile($"./images/{fileName}", access = Enums.Access.Sequential)
        .Heifsave(
            $"./output/netvips/rido-archive-{fileName}.avif",
            effort = 3,
            q = 80,
            compression = Enums.ForeignHeifCompression.Av1
        )
// }


let images =
    [| "large-image1.jpg"
       "large-image2.jpg"
       "large-image3.jpg"
       "large-image4.jpg"
       "large-image5.jpg"
       "large-image6.jpg"
       "large-image7.jpg"
       "large-image8.jpg"
       "large-image9.jpg"
       "large-image10.jpg"
       "large-image11.jpg"
       "large-image12.jpg"
       "large-image13.jpg"
       "large-image14.jpg"
       "large-image15.jpg"
       "large-image16.jpg"
       "large-image17.jpg"
       "large-image18.jpg"
       "large-image19.jpg"
       "large-image20.jpg"
       "large-image21.jpg"
       "large-image22.jpg"
       "large-image23.jpg"
       "large-image24.jpg"
       "large-image25.jpg"
       "large-image26.jpg"
       "large-image27.jpg"
       "large-image28.jpg"
       "large-image29.jpg"
       "large-image30.jpg"
       "large-image31.jpg"
       "large-image32.jpg"
       "large-image33.jpg"
       "large-image34.jpg"
       "large-image35.jpg"
       "large-image36.jpg"
       "large-image37.jpg"
       "large-image38.jpg"
       "large-image39.jpg"
       "large-image40.jpg"
       "large-image41.jpg"
       "large-image42.jpg"
       "large-image43.jpg"
       "large-image44.jpg"
       "large-image45.jpg"
       "large-image46.jpg"
       "large-image47.jpg"
       "large-image48.jpg"
       "large-image49.jpg"
       "large-image50.jpg"
       "large-image51.jpg"
       "dog.jpg"
       "person.jpg" |]

[<EntryPoint>]
let main _ =
    let sw = System.Diagnostics.Stopwatch.StartNew()

    Parallel.ForEach(
        images,
        new ParallelOptions(MaxDegreeOfParallelism = 4),
        fun image ->
            createThumbnail image
            convertImageToOptimizedFormat image
            convertImageToArchiveFormat image
    )
    |> ignore

    printfn "NetVips Test Took: %A" sw.Elapsed
    0
