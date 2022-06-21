<template>
  <div class="card md:card-side card-compact bg-base-100 border border-base-300
   hover:shadow-2xl h-full hover:bg-base-200">
    <figure>
      <div style="height:280px; width:200px">
        <img
          :src="props.item.posterPath || '/img/standart.png'"
          alt="Movie"
          class="h-full w-full object-contain"
        />
      </div>
    </figure>
    <div class="card-body" style="width: 300px">
      <h2 class="card-title text-2xl font-navigation capitalize">{{props.item.title}}</h2>
      <p>
        <span class="text-error font-bold text-3xl">
          {{(new Date(props.item.startDate)).toLocaleString().split(' ')[0]}}
        </span>
        <br>
        <span class="text-error font-bold text-xl">
          {{(new Date(props.item.startDate)).toLocaleString().split(' ')[1]}}
        </span>
        <br><br>
        <span class="text-primary font-bold text-xl">
          {{props.item.placeTitle}},
        </span>
        <br>
        <span class="text-success font-bold text-2xl">
          {{props.item.city}}
        </span>
      </p>
      <div class="card-actions justify-end">
        <router-link :to="{
            name: 'Activity',
            params: {
              categoryName: props.item.category.name,
              categoryId: props.item.categoryId,
              activityName: props.item.title,
              activityId: props.item.id
            }
          }"
          class="btn btn-primary">
          Detay
        </router-link>
      </div>
    </div>
  </div>
</template>

<script setup>
const props = defineProps({
  item: {
    type: Object,
    required: true,
  },
});
</script>

<style>
.card img {
  filter: blur(0.5px) grayscale(0.8);
  transition: 0.5s;
}

.card:hover img {
  filter: blur(0px) grayscale(0) drop-shadow(10px 0px 10px gray);
}
</style>
