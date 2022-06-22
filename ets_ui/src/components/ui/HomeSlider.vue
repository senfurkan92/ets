<template>
  <div class="body shadow-sm bg-gradient-to-b from-base-100 via-base-100 to-base-300">
    <swiper
      :slidesPerView="1"
      :spaceBetween="10"
      :pagination="{
        clickable: true,
      }"
      :breakpoints="{
        '500': {
          slidesPerView: 2,
          spaceBetween: 20,
        },
        '768': {
          slidesPerView: 3,
          spaceBetween: 40,
        },
        '1024': {
          slidesPerView: 4,
          spaceBetween: 50,
        },
      }"
      :modules="modules"
      class="mySwiper"
    >
      <swiper-slide v-for="activity in $store.state.activity.recentList"
        :key="activity.id"
        class="relative bg-transparent">
        <router-link :to="{
            name: 'Activity',
            params: {
              categoryName: activity.category.name,
              categoryId: activity.categoryId,
              activityName: activity.title,
              activityId: activity.id
            }
          }">
          <div class="w-full relative img-container bg-transparent scale-95
            hover:scale-100" style="height: 50vh">
            <img class="h-full w-full object-contain"
              :src="activity.posterPath || '/img/standart.png'"
              alt=""
            />
          </div>
        </router-link>
        <div class="text-black z-40 absolute bottom-0 text-2xl
              text-center w-full bg-warning pt-2 pb-5 px-1 font-bold
              font-navigation">
              {{activity.title}}
            </div>
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

.img-container img {
  filter: blur(0.5px) grayscale(0.1);
  transition: 0.25s;
}

.img-container:hover img {
  filter: blur(0px) grayscale(0) drop-shadow(10px 0px 10px gray);
}
</style>
