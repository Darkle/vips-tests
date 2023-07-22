module VipsTest

open NetVips

// https://www.libvips.org/API/current/func-list.html
// TODO: some things need to be changed to use settings.
// TODO: ALSO, have effort be a setting. May as well.

let createThumbnail fileName =
    let image = Image.NewFromFile($"./images/{fileName}", access = Enums.Access.Random)

    // https://kleisauke.github.io/net-vips/api/NetVips.Enums.Interesting.html
    // https://www.libvips.org/API/current/VipsForeignSave.html#vips-webpsave
    image
        .ThumbnailImage(width = 100, height = 100, crop = Enums.Interesting.Attention)
        .Webpsave($"./output/netvips/rido-thumb-{fileName}.webp", effort = 4, q = 70)

let convertImageToOptimizedFormat fileName =
    let image = Image.NewFromFile($"./images/{fileName}", access = Enums.Access.Random)
    // TODO: this needs to be changed to settings
    // https://www.libvips.org/API/current/VipsForeignSave.html#vips-webpsave
    if image.Width > 1400 then
        image
            .ThumbnailImage(width = 1400)
            .Webpsave($"./output/netvips/rido-optimized-{fileName}.webp", effort = 4, q = 80)
    else
        image.Webpsave($"./output/netvips/rido-optimized-{fileName}.webp", effort = 4, q = 80)


let convertImageToArchiveFormat fileName =
    let image = Image.NewFromFile($"./images/{fileName}", access = Enums.Access.Random)
    // https://www.libvips.org/API/current/VipsForeignSave.html#vips-heifsave
    // In my tests, above 4 didn't seem to be worth it in terms of bytes reduced.
    image.Heifsave(
        $"./output/netvips/rido-archive-{fileName}.avif",
        effort = 4,
        q = 80,
        compression = Enums.ForeignHeifCompression.Av1
    )


[<EntryPoint>]
let main _ =
    createThumbnail "large-image.jpg"
    createThumbnail "chv1.jpg"
    createThumbnail "chv2.jpg"
    createThumbnail "chv3.jpg"
    createThumbnail "dog.jpg"
    createThumbnail "person.jpg"

    convertImageToOptimizedFormat "large-image.jpg"
    convertImageToOptimizedFormat "chv1.jpg"
    convertImageToOptimizedFormat "chv2.jpg"
    convertImageToOptimizedFormat "chv3.jpg"
    convertImageToOptimizedFormat "dog.jpg"
    convertImageToOptimizedFormat "person.jpg"

    convertImageToArchiveFormat "large-image.jpg"
    convertImageToArchiveFormat "chv1.jpg"
    convertImageToArchiveFormat "chv2.jpg"
    convertImageToArchiveFormat "chv3.jpg"
    convertImageToArchiveFormat "dog.jpg"
    convertImageToArchiveFormat "person.jpg"
    0
