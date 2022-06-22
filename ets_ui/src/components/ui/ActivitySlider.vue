<template>
  <div class="body bg-gradient-to-b from-base-100 via-base-100 to-base-200 shadow-sm
    rounded-b-lg mx-auto">
    <swiper
      :effect="'coverflow'"
      :grabCursor="true"
      :centeredSlides="true"
      :slidesPerView="'auto'"
      :coverflowEffect="{
        rotate: 50,
        stretch: 0,
        depth: 100,
        modifier: 1,
        slideShadows: true,
      }"
      :pagination="true"
      :modules="modules"
      class="mySwiper"
    >
      <swiper-slide v-for="image in props.images" :key="image.id"
        ><img class="h-full w-full object-contain"
          :src="image.path"
          alt="" />
      </swiper-slide>
    </swiper>
  </div>
</template>

<script setup>
// Import Swiper Vue.js components
import { Swiper, SwiperSlide } from 'swiper/vue';

// Import Swiper styles
// eslint-disable-next-line import/extensions
import 'swiper/css';

// eslint-disable-next-line import/extensions
import 'swiper/css/effect-coverflow';

// eslint-disable-next-line import/extensions
import 'swiper/css/pagination';

// import required modules
import { EffectCoverflow, Pagination } from 'swiper';

const props = defineProps({
  images: {
    type: Array,
  },
});

const modules = [EffectCoverflow, Pagination];
</script>

<style>
.body {
  position: relative;
  height: 100%;
}

.body {
  font-family: Helvetica Neue, Helvetica, Arial, sans-serif;
  font-size: 14px;
  color: #000;
  margin: 0;
  padding: 0;
}

.swiper {
  width: 100%;
  padding-top: 50px;
  padding-bottom: 50px;
}

.swiper-slide {
  background-position: center;
  background-size: cover;
  width: 300px;
  height: 300px;
  user-select: none;
}

.swiper-slide img {
  display: block;
  width: 100%;
}
</style>
