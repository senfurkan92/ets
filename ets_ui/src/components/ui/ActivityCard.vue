<template>
  <div class="card card-side bg-base-100 border border-base-300 hover:shadow-2xl h-full
    hover:bg-base-200">
    <figure>
      <img src="https://api.lorem.space/image/movie?w=200&h=280" alt="Movie" />
    </figure>
    <div class="card-body">
      <h2 class="card-title">New movie is released!</h2>
      <p>Click the button to watch on Jetflix app.</p>
      <div class="card-actions justify-end">
        <router-link :to="{
            name: 'Activity',
            params: {
              categoryName: 'tiyatro',
              categoryId: 1,
              activityName: 'Tarkan Konser',
              activityId: 1
            }
          }"
          class="btn btn-primary">
          Watch
        </router-link>
      </div>
    </div>
  </div>
</template>

<style>
.card img {
  filter: blur(0.5px) grayscale(0.8);
  transition: 0.5s;
}

.card:hover img {
  filter: blur(0px) grayscale(0) drop-shadow(10px 0px 10px gray);
}
</style>
