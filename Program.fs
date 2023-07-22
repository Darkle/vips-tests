module VipsTest

open NetVips

// https://www.libvips.org/API/current/func-list.html
// TODO: some things need to be changed to use settings.

let createThumbnail fileName =
    task {
        // https://kleisauke.github.io/net-vips/api/NetVips.Enums.Interesting.html
        // https://www.libvips.org/API/current/VipsForeignSave.html#vips-webpsave
        Image
            .NewFromFile($"./images/{fileName}", access = Enums.Access.Sequential)
            .ThumbnailImage(width = 100, height = 100, crop = Enums.Interesting.Attention)
            .Webpsave($"./output/netvips/rido-thumb-{fileName}.webp", effort = 3, q = 70)
    }

let convertImageToOptimizedFormat fileName =
    task {
        let image =
            Image.NewFromFile($"./images/{fileName}", access = Enums.Access.Sequential)
        // TODO: this needs to be changed to settings
        // https://www.libvips.org/API/current/VipsForeignSave.html#vips-webpsave
        if image.Width > 1400 then
            image
                .ThumbnailImage(width = 1400)
                .Webpsave($"./output/netvips/rido-optimized-{fileName}.webp", effort = 3, q = 80)
        else
            image.Webpsave($"./output/netvips/rido-optimized-{fileName}.webp", effort = 3, q = 80)
    }

let convertImageToArchiveFormat fileName =
    task {
        // https://www.libvips.org/API/current/VipsForeignSave.html#vips-heifsave
        Image
            .NewFromFile($"./images/{fileName}", access = Enums.Access.Sequential)
            .Heifsave(
                $"./output/netvips/rido-archive-{fileName}.avif",
                effort = 3,
                q = 80,
                compression = Enums.ForeignHeifCompression.Av1
            )
    }


[<EntryPoint>]
let main _ =
    let sw = System.Diagnostics.Stopwatch.StartNew()

    createThumbnail "large-image1.jpg" |> ignore
    createThumbnail "large-image2.jpg" |> ignore
    createThumbnail "large-image3.jpg" |> ignore
    createThumbnail "large-image4.jpg" |> ignore
    createThumbnail "large-image5.jpg" |> ignore
    createThumbnail "large-image6.jpg" |> ignore
    createThumbnail "large-image7.jpg" |> ignore
    createThumbnail "large-image8.jpg" |> ignore
    createThumbnail "large-image9.jpg" |> ignore
    createThumbnail "large-image10.jpg" |> ignore
    createThumbnail "large-image11.jpg" |> ignore
    createThumbnail "large-image12.jpg" |> ignore
    createThumbnail "large-image13.jpg" |> ignore
    createThumbnail "large-image14.jpg" |> ignore
    createThumbnail "large-image15.jpg" |> ignore
    createThumbnail "large-image16.jpg" |> ignore
    createThumbnail "large-image17.jpg" |> ignore
    createThumbnail "large-image18.jpg" |> ignore
    createThumbnail "large-image19.jpg" |> ignore
    createThumbnail "large-image20.jpg" |> ignore
    createThumbnail "large-image21.jpg" |> ignore
    createThumbnail "large-image22.jpg" |> ignore
    createThumbnail "large-image23.jpg" |> ignore
    createThumbnail "large-image24.jpg" |> ignore
    createThumbnail "large-image25.jpg" |> ignore
    createThumbnail "large-image26.jpg" |> ignore
    createThumbnail "large-image27.jpg" |> ignore
    createThumbnail "large-image28.jpg" |> ignore
    createThumbnail "large-image29.jpg" |> ignore
    createThumbnail "large-image30.jpg" |> ignore
    createThumbnail "large-image31.jpg" |> ignore
    createThumbnail "large-image32.jpg" |> ignore
    createThumbnail "large-image33.jpg" |> ignore
    createThumbnail "large-image34.jpg" |> ignore
    createThumbnail "large-image35.jpg" |> ignore
    createThumbnail "large-image36.jpg" |> ignore
    createThumbnail "large-image37.jpg" |> ignore
    createThumbnail "large-image38.jpg" |> ignore
    createThumbnail "large-image39.jpg" |> ignore
    createThumbnail "large-image40.jpg" |> ignore
    createThumbnail "large-image41.jpg" |> ignore
    createThumbnail "large-image42.jpg" |> ignore
    createThumbnail "large-image43.jpg" |> ignore
    createThumbnail "large-image44.jpg" |> ignore
    createThumbnail "large-image45.jpg" |> ignore
    createThumbnail "large-image46.jpg" |> ignore
    createThumbnail "large-image47.jpg" |> ignore
    createThumbnail "large-image48.jpg" |> ignore
    createThumbnail "large-image49.jpg" |> ignore
    createThumbnail "large-image50.jpg" |> ignore
    createThumbnail "large-image51.jpg" |> ignore
    createThumbnail "dog.jpg" |> ignore
    createThumbnail "person.jpg" |> ignore

    convertImageToOptimizedFormat "large-image1.jpg" |> ignore
    convertImageToOptimizedFormat "large-image2.jpg" |> ignore
    convertImageToOptimizedFormat "large-image3.jpg" |> ignore
    convertImageToOptimizedFormat "large-image4.jpg" |> ignore
    convertImageToOptimizedFormat "large-image5.jpg" |> ignore
    convertImageToOptimizedFormat "large-image6.jpg" |> ignore
    convertImageToOptimizedFormat "large-image7.jpg" |> ignore
    convertImageToOptimizedFormat "large-image8.jpg" |> ignore
    convertImageToOptimizedFormat "large-image9.jpg" |> ignore
    convertImageToOptimizedFormat "large-image10.jpg" |> ignore
    convertImageToOptimizedFormat "large-image11.jpg" |> ignore
    convertImageToOptimizedFormat "large-image12.jpg" |> ignore
    convertImageToOptimizedFormat "large-image13.jpg" |> ignore
    convertImageToOptimizedFormat "large-image14.jpg" |> ignore
    convertImageToOptimizedFormat "large-image15.jpg" |> ignore
    convertImageToOptimizedFormat "large-image16.jpg" |> ignore
    convertImageToOptimizedFormat "large-image17.jpg" |> ignore
    convertImageToOptimizedFormat "large-image18.jpg" |> ignore
    convertImageToOptimizedFormat "large-image19.jpg" |> ignore
    convertImageToOptimizedFormat "large-image20.jpg" |> ignore
    convertImageToOptimizedFormat "large-image21.jpg" |> ignore
    convertImageToOptimizedFormat "large-image22.jpg" |> ignore
    convertImageToOptimizedFormat "large-image23.jpg" |> ignore
    convertImageToOptimizedFormat "large-image24.jpg" |> ignore
    convertImageToOptimizedFormat "large-image25.jpg" |> ignore
    convertImageToOptimizedFormat "large-image26.jpg" |> ignore
    convertImageToOptimizedFormat "large-image27.jpg" |> ignore
    convertImageToOptimizedFormat "large-image28.jpg" |> ignore
    convertImageToOptimizedFormat "large-image29.jpg" |> ignore
    convertImageToOptimizedFormat "large-image30.jpg" |> ignore
    convertImageToOptimizedFormat "large-image31.jpg" |> ignore
    convertImageToOptimizedFormat "large-image32.jpg" |> ignore
    convertImageToOptimizedFormat "large-image33.jpg" |> ignore
    convertImageToOptimizedFormat "large-image34.jpg" |> ignore
    convertImageToOptimizedFormat "large-image35.jpg" |> ignore
    convertImageToOptimizedFormat "large-image36.jpg" |> ignore
    convertImageToOptimizedFormat "large-image37.jpg" |> ignore
    convertImageToOptimizedFormat "large-image38.jpg" |> ignore
    convertImageToOptimizedFormat "large-image39.jpg" |> ignore
    convertImageToOptimizedFormat "large-image40.jpg" |> ignore
    convertImageToOptimizedFormat "large-image41.jpg" |> ignore
    convertImageToOptimizedFormat "large-image42.jpg" |> ignore
    convertImageToOptimizedFormat "large-image43.jpg" |> ignore
    convertImageToOptimizedFormat "large-image44.jpg" |> ignore
    convertImageToOptimizedFormat "large-image45.jpg" |> ignore
    convertImageToOptimizedFormat "large-image46.jpg" |> ignore
    convertImageToOptimizedFormat "large-image47.jpg" |> ignore
    convertImageToOptimizedFormat "large-image48.jpg" |> ignore
    convertImageToOptimizedFormat "large-image49.jpg" |> ignore
    convertImageToOptimizedFormat "large-image50.jpg" |> ignore
    convertImageToOptimizedFormat "large-image51.jpg" |> ignore
    convertImageToOptimizedFormat "dog.jpg" |> ignore
    convertImageToOptimizedFormat "person.jpg" |> ignore

    convertImageToArchiveFormat "large-image1.jpg" |> ignore
    convertImageToArchiveFormat "large-image2.jpg" |> ignore
    convertImageToArchiveFormat "large-image3.jpg" |> ignore
    convertImageToArchiveFormat "large-image4.jpg" |> ignore
    convertImageToArchiveFormat "large-image5.jpg" |> ignore
    convertImageToArchiveFormat "large-image6.jpg" |> ignore
    convertImageToArchiveFormat "large-image7.jpg" |> ignore
    convertImageToArchiveFormat "large-image8.jpg" |> ignore
    convertImageToArchiveFormat "large-image9.jpg" |> ignore
    convertImageToArchiveFormat "large-image10.jpg" |> ignore
    convertImageToArchiveFormat "large-image11.jpg" |> ignore
    convertImageToArchiveFormat "large-image12.jpg" |> ignore
    convertImageToArchiveFormat "large-image13.jpg" |> ignore
    convertImageToArchiveFormat "large-image14.jpg" |> ignore
    convertImageToArchiveFormat "large-image15.jpg" |> ignore
    convertImageToArchiveFormat "large-image16.jpg" |> ignore
    convertImageToArchiveFormat "large-image17.jpg" |> ignore
    convertImageToArchiveFormat "large-image18.jpg" |> ignore
    convertImageToArchiveFormat "large-image19.jpg" |> ignore
    convertImageToArchiveFormat "large-image20.jpg" |> ignore
    convertImageToArchiveFormat "large-image21.jpg" |> ignore
    convertImageToArchiveFormat "large-image22.jpg" |> ignore
    convertImageToArchiveFormat "large-image23.jpg" |> ignore
    convertImageToArchiveFormat "large-image24.jpg" |> ignore
    convertImageToArchiveFormat "large-image25.jpg" |> ignore
    convertImageToArchiveFormat "large-image26.jpg" |> ignore
    convertImageToArchiveFormat "large-image27.jpg" |> ignore
    convertImageToArchiveFormat "large-image28.jpg" |> ignore
    convertImageToArchiveFormat "large-image29.jpg" |> ignore
    convertImageToArchiveFormat "large-image30.jpg" |> ignore
    convertImageToArchiveFormat "large-image31.jpg" |> ignore
    convertImageToArchiveFormat "large-image32.jpg" |> ignore
    convertImageToArchiveFormat "large-image33.jpg" |> ignore
    convertImageToArchiveFormat "large-image34.jpg" |> ignore
    convertImageToArchiveFormat "large-image35.jpg" |> ignore
    convertImageToArchiveFormat "large-image36.jpg" |> ignore
    convertImageToArchiveFormat "large-image37.jpg" |> ignore
    convertImageToArchiveFormat "large-image38.jpg" |> ignore
    convertImageToArchiveFormat "large-image39.jpg" |> ignore
    convertImageToArchiveFormat "large-image40.jpg" |> ignore
    convertImageToArchiveFormat "large-image41.jpg" |> ignore
    convertImageToArchiveFormat "large-image42.jpg" |> ignore
    convertImageToArchiveFormat "large-image43.jpg" |> ignore
    convertImageToArchiveFormat "large-image44.jpg" |> ignore
    convertImageToArchiveFormat "large-image45.jpg" |> ignore
    convertImageToArchiveFormat "large-image46.jpg" |> ignore
    convertImageToArchiveFormat "large-image47.jpg" |> ignore
    convertImageToArchiveFormat "large-image48.jpg" |> ignore
    convertImageToArchiveFormat "large-image49.jpg" |> ignore
    convertImageToArchiveFormat "large-image50.jpg" |> ignore
    convertImageToArchiveFormat "large-image51.jpg" |> ignore
    convertImageToArchiveFormat "dog.jpg" |> ignore
    convertImageToArchiveFormat "person.jpg" |> ignore

    printfn "NetVips Test Took: %A" sw.Elapsed
    0
