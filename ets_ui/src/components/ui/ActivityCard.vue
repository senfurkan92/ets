<template>
  <div class="card md:card-side card-compact bg-base-100 border border-base-300
   hover:shadow-2xl h-full hover:bg-base-200">
    <figure>
      <div style="height:280px; width:200px">
        <router-link :to="{
            name: 'Activity',
            params: {
              categoryName: props.item.category.name,
              categoryId: props.item.categoryId,
              activityName: props.item.title,
              activityId: props.item.id
            }
          }">
          <img
            :src="props.item.posterPath || '/img/standart.png'"
            alt="Movie"
            class="h-full w-full object-contain"
          />
        </router-link>
      </div>
    </figure>
    <div class="card-body" style="width: 300px">
      <h2 class="card-title text-2xl font-navigation capitalize text-error">
        {{props.item.title}}
      </h2>
      <div>
        <div class="flex flex-row items-center mb-4">
          <div class="mr-4">
            <span class=" text-6xl font-bold">
              {{(new Date(props.item.startDate)).getDate()}}
            </span>
          </div>
          <div class="mr-4 text-center">
            <span class=" text-xl font-bold">
              {{(new Date(props.item.startDate)).toLocaleString('tr', {  month: 'short' })}}
            </span>
            <br>
            <span class=" text-xl font-bold">
              {{(new Date(props.item.startDate)).getFullYear()}}
            </span>
          </div>
          <div class="mr-4 text-center">
            <span class=" text-xl font-bold">
              {{(new Date(props.item.startDate)).toLocaleString('tr', {  weekday: 'short' })}}
            </span>
            <br>
            <span class="text-xl font-bold">
              {{(new Date(props.item.startDate)).toLocaleTimeString('tr', {
                hour: '2-digit',
                minute: '2-digit',
              })}}
            </span>
          </div>
        </div>
        <div class="capitalize font-bold text-2xl">
          {{props.item.city}}
        </div>
      </div>
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
          class="btn btn-secondary">
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

<style scoped>
.card img {
  filter: blur(0.5px) grayscale(0.8);
  transition: 0.5s;
}

.card:hover img {
  filter: blur(0px) grayscale(0) drop-shadow(10px 0px 10px gray);
}
</style>
