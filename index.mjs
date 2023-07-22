import sharp from 'sharp'

const createThumbnail = fileName =>
  sharp(`./images/${fileName}`)
    .resize({
      width: 100,
      height: 100,
      fit: 'cover',
      position: sharp.strategy.attention,
    })
    .webp({ quality: 70, effort: 3 })
    .toFile(`./output/sharp/rido-thumb-${fileName}.webp`)
    .catch(err => {
      console.error(err)
    })

const convertImageToOptimizedFormat = fileName =>
  sharp(`./images/${fileName}`)
    .withMetadata()
    .resize({
      width: 1400,
      fit: 'inside',
      position: sharp.strategy.attention,
      // Only resize image if it is larger. If smaller, don't resize.
      withoutEnlargement: true,
    })
    .webp({ quality: 80, effort: 3 })
    .toFile(`./output/sharp/rido-optimized-${fileName}.webp`)
    .catch(err => {
      console.error(err)
    })

const convertImageToArchiveFormat = fileName =>
  sharp(`./images/${fileName}`)
    .withMetadata()
    .avif({
      quality: 80,
      effort: 3,
    })
    .toFile(`./output/sharp/rido-archive-${fileName}.avif`)
    .catch(err => {
      console.error(err)
    })

console.time('node-sharp-test')

Promise.all([
  createThumbnail('large-image.jpg'),
  createThumbnail('dog.jpg'),
  createThumbnail('person.jpg'),

  convertImageToOptimizedFormat('large-image.jpg'),
  convertImageToOptimizedFormat('dog.jpg'),
  convertImageToOptimizedFormat('person.jpg'),

  convertImageToArchiveFormat('large-image.jpg'),
  convertImageToArchiveFormat('dog.jpg'),
  convertImageToArchiveFormat('person.jpg'),
]).finally(() => {
  console.timeEnd('node-sharp-test')
})
