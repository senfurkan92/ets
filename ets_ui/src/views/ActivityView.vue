<template>
  <div class="text-center mb-10">
    <h2 class="text-4xl uppercase font-semibold font-title tracking-widest">
      {{toTurkishUpper($route.params.categoryName)}}
    </h2>
  </div>
  <div class="grid grid-cols-4 gap-8" v-if="activity">
    <!-- POSTER -->
    <div class="lg:col-span-1 md:col-span-2 col-span-4 flex justify-center">
      <div class="aspect-[5/7]" style="width: clamp(300px, 100%, 500px); max-width: 90vw">
        <img style="filter: drop-shadow(10px 0px 10px gray)"
          class="w-full h-full object-contain"
          :src="activity.posterPath || '/img/standart.png'" alt=""/>
      </div>
    </div>
    <!-- DATE AND LOCATION -->
    <div class="lg:col-span-1 md:col-span-2 col-span-4 md:px-0 px-8">
      <div class="flex flex-row items-center mb-4">
        <div class="mr-4">
          <span class=" text-8xl font-bold">
            {{(new Date(activity.startDate)).getDate()}}
          </span>
        </div>
        <div class="mr-4 text-center">
          <span class=" text-3xl font-bold">
            {{(new Date(activity.startDate)).toLocaleString('tr', {  month: 'short' })}}
          </span>
          <br>
          <span class=" text-2xl font-bold">
            {{(new Date(activity.startDate)).getFullYear()}}
          </span>
        </div>
        <div class="mr-4 text-center">
          <span class=" text-3xl font-bold">
            {{(new Date(activity.startDate)).toLocaleString('tr', {  weekday: 'short' })}}
          </span>
          <br>
          <span class="text-2xl font-bold">
            {{(new Date(activity.startDate)).toLocaleTimeString('tr', {
              hour: '2-digit',
              minute: '2-digit',
            })}}
          </span>
        </div>
      </div>
      <div style="max-width: 400px">
        <span class="text-3xl font-bold text-error">{{activity.placeTitle}},</span>
        <br>
        <span class="text-2xl font-bold">{{activity.city}}</span>
        <br><br>
        <span class="italic">{{activity.address}}</span>
      </div>
    </div>
    <!-- MAP LOCATION -->
    <div class="lg:col-span-2 lg:flex hidden justify-center scale-75">
      <iframe title="" :src="activity.mapLocation || 'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d24483.207286767785!2d32.760805773334596!3d39.9100435019644!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d3489dbdce88e5%3A0x3b7ba3b8611e1e12!2sEts%20Tur!5e0!3m2!1str!2str!4v1655844892790!5m2!1str!2str'" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
    </div>
    <!-- TITLE -->
    <div class="col-span-4 px-8 text-xl font-bold uppercase">
      {{toTurkishUpper(activity.title)}}
    </div>
    <!-- DESCRIPTION -->
    <div class="col-span-4 px-8 text-lg">
      {{activity.description}}
    </div>
    <!-- TICKETS-->
    <div class="col-span-4 px-8">
      <h3 class="text-xl font-bold">
        Bilet Fiyatları
      </h3>
      <hr>
      <ul>
        <li v-for="ticket in activity.tickets" :key="ticket.id">
          <span class="font-bold capitalize">{{ticket.title}}</span>:
          {{formatter.format(ticket.fee)}}
        </li>
      </ul>
    </div>
    <div class="col-span-4 px-8 overflow-x-hidden" v-if="activity.images" style="max-width: 100vw">
      <ActivitySlider :images="activity.images"/>
    </div>
    <div class="col-span-4 px-8 justify-center lg:hidden flex">
      <!-- eslint-disable max-len -->
      <iframe title="" :src="activity.mapLocation || 'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d24483.207286767785!2d32.760805773334596!3d39.9100435019644!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d3489dbdce88e5%3A0x3b7ba3b8611e1e12!2sEts%20Tur!5e0!3m2!1str!2str!4v1655844892790!5m2!1str!2str'" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
    </div>
  </div>
</template>

<script setup>
import ActivitySlider from '@/components/ui/ActivitySlider.vue';
import { toTurkishUpper, formatter } from '@/utils/methods';
import { useStore } from 'vuex';
import { useRoute } from 'vue-router';
import { onMounted, ref } from 'vue';

const store = useStore();
const route = useRoute();
const activity = ref(null);

onMounted(() => {
  store.dispatch('activity/fetchItem', route.params.activityId)
    .then((resp) => {
      if (resp.data.success) {
        activity.value = resp.data.result;
      }
    });
});
</script>

<style>

</style>
