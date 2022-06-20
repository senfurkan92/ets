<template>
  <div class="text-center mb-10">
    <h2 class="text-4xl uppercase font-semibold font-title tracking-widest">
      {{$route.params.activityName}}
    </h2>
  </div>
  <div>
    {{$route.params.categoryName}} / {{$route.params.categoryId}}
    <br />
    {{$route.params.activityName}} / {{$route.params.activityId}}
  </div>
</template>

<script setup>

</script>

<style>

</style>
