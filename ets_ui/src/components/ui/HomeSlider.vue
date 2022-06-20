<template>
  <div class="body shadow-sm bg-gradient-to-b from-base-100 via-base-100 to-base-300">
    <swiper
      :slidesPerView="1"
      :spaceBetween="10"
      :pagination="{
        clickable: true,
      }"
      :breakpoints="{
        '640': {
          slidesPerView: 2,
          spaceBetween: 20,
        },
        '768': {
          slidesPerView: 4,
          spaceBetween: 40,
        },
        '1024': {
          slidesPerView: 5,
          spaceBetween: 50,
        },
      }"
      :modules="modules"
      class="mySwiper"
    >
      <swiper-slide v-for="n in 9" :key="n" class="shadow-lg hover:scale-105">
        <router-link :to="{
            name: 'Activity',
            params: {
              categoryName: 'tiyatro',
              categoryId: 1,
              activityName: 'Tarkan Konser',
              activityId: 1
            }
          }">
          <img class="h-full w-full object-contain"
            src="https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/a944da54063079.594ce3e22a882.jpg"
            alt=""
          />
        </router-link>
      </swiper-slide>
    </swiper>
  </div>
</template>

<script>
// Import Swiper Vue.js components
import { Swiper, SwiperSlide } from 'swiper/vue';

// Import Swiper styles
// eslint-disable-next-line import/extensions
import 'swiper/css';

// eslint-disable-next-line import/extensions
import 'swiper/css/pagination';

// import required modules
import { Pagination } from 'swiper';

export default {
  components: {
    Swiper,
    SwiperSlide,
  },
  setup() {
    return {
      modules: [Pagination],
    };
  },
};
</script>

<style>
.body {
  position: relative;
  height: 100%;
  max-width: 100vw;
  max-height: 50vh;
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
  height: 100%;
}

.swiper-slide {
  text-align: center;
  font-size: 18px;
  background: #fff;

  /* Center slide text vertically */
  display: -webkit-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-box-pack: center;
  -ms-flex-pack: center;
  -webkit-justify-content: center;
  justify-content: center;
  -webkit-box-align: center;
  -ms-flex-align: center;
  -webkit-align-items: center;
  align-items: center;
}
</style>
