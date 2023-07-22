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
  createThumbnail('large-image1.jpg'),
  createThumbnail('large-image2.jpg'),
  createThumbnail('large-image3.jpg'),
  createThumbnail('large-image4.jpg'),
  createThumbnail('large-image5.jpg'),
  createThumbnail('large-image6.jpg'),
  createThumbnail('large-image7.jpg'),
  createThumbnail('large-image8.jpg'),
  createThumbnail('large-image9.jpg'),
  createThumbnail('large-image10.jpg'),
  createThumbnail('large-image11.jpg'),
  createThumbnail('large-image12.jpg'),
  createThumbnail('large-image13.jpg'),
  createThumbnail('large-image14.jpg'),
  createThumbnail('large-image15.jpg'),
  createThumbnail('large-image16.jpg'),
  createThumbnail('large-image17.jpg'),
  createThumbnail('large-image18.jpg'),
  createThumbnail('large-image19.jpg'),
  createThumbnail('large-image20.jpg'),
  createThumbnail('large-image21.jpg'),
  createThumbnail('large-image22.jpg'),
  createThumbnail('large-image23.jpg'),
  createThumbnail('large-image24.jpg'),
  createThumbnail('large-image25.jpg'),
  createThumbnail('large-image26.jpg'),
  createThumbnail('large-image27.jpg'),
  createThumbnail('large-image28.jpg'),
  createThumbnail('large-image29.jpg'),
  createThumbnail('large-image30.jpg'),
  createThumbnail('large-image31.jpg'),
  createThumbnail('large-image32.jpg'),
  createThumbnail('large-image33.jpg'),
  createThumbnail('large-image34.jpg'),
  createThumbnail('large-image35.jpg'),
  createThumbnail('large-image36.jpg'),
  createThumbnail('large-image37.jpg'),
  createThumbnail('large-image38.jpg'),
  createThumbnail('large-image39.jpg'),
  createThumbnail('large-image40.jpg'),
  createThumbnail('large-image41.jpg'),
  createThumbnail('large-image42.jpg'),
  createThumbnail('large-image43.jpg'),
  createThumbnail('large-image44.jpg'),
  createThumbnail('large-image45.jpg'),
  createThumbnail('large-image46.jpg'),
  createThumbnail('large-image47.jpg'),
  createThumbnail('large-image48.jpg'),
  createThumbnail('large-image49.jpg'),
  createThumbnail('large-image50.jpg'),
  createThumbnail('large-image51.jpg'),
  createThumbnail('dog.jpg'),
  createThumbnail('person.jpg'),

  convertImageToOptimizedFormat('large-image1.jpg'),
  convertImageToOptimizedFormat('large-image2.jpg'),
  convertImageToOptimizedFormat('large-image3.jpg'),
  convertImageToOptimizedFormat('large-image4.jpg'),
  convertImageToOptimizedFormat('large-image5.jpg'),
  convertImageToOptimizedFormat('large-image6.jpg'),
  convertImageToOptimizedFormat('large-image7.jpg'),
  convertImageToOptimizedFormat('large-image8.jpg'),
  convertImageToOptimizedFormat('large-image9.jpg'),
  convertImageToOptimizedFormat('large-image10.jpg'),
  convertImageToOptimizedFormat('large-image11.jpg'),
  convertImageToOptimizedFormat('large-image12.jpg'),
  convertImageToOptimizedFormat('large-image13.jpg'),
  convertImageToOptimizedFormat('large-image14.jpg'),
  convertImageToOptimizedFormat('large-image15.jpg'),
  convertImageToOptimizedFormat('large-image16.jpg'),
  convertImageToOptimizedFormat('large-image17.jpg'),
  convertImageToOptimizedFormat('large-image18.jpg'),
  convertImageToOptimizedFormat('large-image19.jpg'),
  convertImageToOptimizedFormat('large-image20.jpg'),
  convertImageToOptimizedFormat('large-image21.jpg'),
  convertImageToOptimizedFormat('large-image22.jpg'),
  convertImageToOptimizedFormat('large-image23.jpg'),
  convertImageToOptimizedFormat('large-image24.jpg'),
  convertImageToOptimizedFormat('large-image25.jpg'),
  convertImageToOptimizedFormat('large-image26.jpg'),
  convertImageToOptimizedFormat('large-image27.jpg'),
  convertImageToOptimizedFormat('large-image28.jpg'),
  convertImageToOptimizedFormat('large-image29.jpg'),
  convertImageToOptimizedFormat('large-image30.jpg'),
  convertImageToOptimizedFormat('large-image31.jpg'),
  convertImageToOptimizedFormat('large-image32.jpg'),
  convertImageToOptimizedFormat('large-image33.jpg'),
  convertImageToOptimizedFormat('large-image34.jpg'),
  convertImageToOptimizedFormat('large-image35.jpg'),
  convertImageToOptimizedFormat('large-image36.jpg'),
  convertImageToOptimizedFormat('large-image37.jpg'),
  convertImageToOptimizedFormat('large-image38.jpg'),
  convertImageToOptimizedFormat('large-image39.jpg'),
  convertImageToOptimizedFormat('large-image40.jpg'),
  convertImageToOptimizedFormat('large-image41.jpg'),
  convertImageToOptimizedFormat('large-image42.jpg'),
  convertImageToOptimizedFormat('large-image43.jpg'),
  convertImageToOptimizedFormat('large-image44.jpg'),
  convertImageToOptimizedFormat('large-image45.jpg'),
  convertImageToOptimizedFormat('large-image46.jpg'),
  convertImageToOptimizedFormat('large-image47.jpg'),
  convertImageToOptimizedFormat('large-image48.jpg'),
  convertImageToOptimizedFormat('large-image49.jpg'),
  convertImageToOptimizedFormat('large-image50.jpg'),
  convertImageToOptimizedFormat('large-image51.jpg'),
  convertImageToOptimizedFormat('dog.jpg'),
  convertImageToOptimizedFormat('person.jpg'),

  convertImageToArchiveFormat('large-image1.jpg'),
  convertImageToArchiveFormat('large-image2.jpg'),
  convertImageToArchiveFormat('large-image3.jpg'),
  convertImageToArchiveFormat('large-image4.jpg'),
  convertImageToArchiveFormat('large-image5.jpg'),
  convertImageToArchiveFormat('large-image6.jpg'),
  convertImageToArchiveFormat('large-image7.jpg'),
  convertImageToArchiveFormat('large-image8.jpg'),
  convertImageToArchiveFormat('large-image9.jpg'),
  convertImageToArchiveFormat('large-image10.jpg'),
  convertImageToArchiveFormat('large-image11.jpg'),
  convertImageToArchiveFormat('large-image12.jpg'),
  convertImageToArchiveFormat('large-image13.jpg'),
  convertImageToArchiveFormat('large-image14.jpg'),
  convertImageToArchiveFormat('large-image15.jpg'),
  convertImageToArchiveFormat('large-image16.jpg'),
  convertImageToArchiveFormat('large-image17.jpg'),
  convertImageToArchiveFormat('large-image18.jpg'),
  convertImageToArchiveFormat('large-image19.jpg'),
  convertImageToArchiveFormat('large-image20.jpg'),
  convertImageToArchiveFormat('large-image21.jpg'),
  convertImageToArchiveFormat('large-image22.jpg'),
  convertImageToArchiveFormat('large-image23.jpg'),
  convertImageToArchiveFormat('large-image24.jpg'),
  convertImageToArchiveFormat('large-image25.jpg'),
  convertImageToArchiveFormat('large-image26.jpg'),
  convertImageToArchiveFormat('large-image27.jpg'),
  convertImageToArchiveFormat('large-image28.jpg'),
  convertImageToArchiveFormat('large-image29.jpg'),
  convertImageToArchiveFormat('large-image30.jpg'),
  convertImageToArchiveFormat('large-image31.jpg'),
  convertImageToArchiveFormat('large-image32.jpg'),
  convertImageToArchiveFormat('large-image33.jpg'),
  convertImageToArchiveFormat('large-image34.jpg'),
  convertImageToArchiveFormat('large-image35.jpg'),
  convertImageToArchiveFormat('large-image36.jpg'),
  convertImageToArchiveFormat('large-image37.jpg'),
  convertImageToArchiveFormat('large-image38.jpg'),
  convertImageToArchiveFormat('large-image39.jpg'),
  convertImageToArchiveFormat('large-image40.jpg'),
  convertImageToArchiveFormat('large-image41.jpg'),
  convertImageToArchiveFormat('large-image42.jpg'),
  convertImageToArchiveFormat('large-image43.jpg'),
  convertImageToArchiveFormat('large-image44.jpg'),
  convertImageToArchiveFormat('large-image45.jpg'),
  convertImageToArchiveFormat('large-image46.jpg'),
  convertImageToArchiveFormat('large-image47.jpg'),
  convertImageToArchiveFormat('large-image48.jpg'),
  convertImageToArchiveFormat('large-image49.jpg'),
  convertImageToArchiveFormat('large-image50.jpg'),
  convertImageToArchiveFormat('large-image51.jpg'),
  convertImageToArchiveFormat('dog.jpg'),
  convertImageToArchiveFormat('person.jpg'),
]).finally(() => {
  console.timeEnd('node-sharp-test')
})
