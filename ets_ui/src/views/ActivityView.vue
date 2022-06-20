<template>
  <div class="text-center mb-10">
    <h2 class="text-4xl uppercase font-semibold font-title tracking-widest">
      {{$route.params.categoryName}}
    </h2>
  </div>
  <div class="grid grid-cols-4 gap-8">
    <!-- POSTER -->
    <div class="lg:col-span-1 md:col-span-2 col-span-4 flex justify-center">
      <div class="aspect-[5/7]" style="width: clamp(300px, 100%, 500px)">
        <img style="filter: drop-shadow(10px 0px 10px gray)"
          class="w-full h-full object-contain"
          src="https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/a944da54063079.594ce3e22a882.jpg" alt=""/>
      </div>
    </div>
    <!-- DATE AND LOCATION -->
    <div class="lg:col-span-1 md:col-span-2 col-span-4 md:px-0 px-8">
      <div class="flex flex-row items-center mb-4">
        <div class="mr-4">
          <span class=" text-8xl font-bold">29</span>
        </div>
        <div class="mr-4 text-center">
          <span class=" text-3xl font-bold">Tem</span>
          <br>
          <span class=" text-2xl font-bold">2022</span>
        </div>
        <div class="mr-4 text-center">
          <span class=" text-3xl font-bold">Cum</span>
          <br>
          <span class="text-2xl font-bold">21:00</span>
        </div>
      </div>
      <div style="max-width: 400px">
        <span class="text-3xl font-bold text-error">Maximum Uniq Açıkhava,</span>
        <br>
        <span class="text-2xl font-bold">Istanbul</span>
      </div>
    </div>
    <!-- TITLE -->
    <div class="col-span-4 px-8 text-xl font-bold">
      Yalın’la Bir Yaz Akşamı “Unutulmaz Şarkılar” 29 Temmuz’da Maximum Uniq Açıkhava’da!
    </div>
    <!-- DESCRIPTION -->
    <div class="col-span-4 px-8 text-lg">
      18 yıllık kariyer yolculuğu boyunca sevenlerinin kalbinde taht kuran ve seslendirdiği kendine
      özgü aşk şarkıları, büyüleyici sesi ve besteleri ile günümüze kadar milyonlarca dinleyici
      kitlesi yakalayan Yalın, bu sezon sahnelerde fırtınalar estiren “Unutulmaz Şarkılar”
      konser serisine Bir Yaz Akşamı “Unutulmaz Şarkılar” olarak Maximum Uniq Açıkhava’da
      devam ediyor.Yalın’ın görkemli sahne tasarımı ve bigband orkestrasıyla hem kalbimizde iz
      bırakan “Unutulmaz Şarkılar”ı, hem de en sevilen hitlerini bu defa yıldızların altında
      seslendireceği konser serisi, 29 Temmuz Cuma günü Maximum Uniq Açıkhava’da sevenleriyle
      buluşacak.
    </div>
    <!-- TICKETS-->
    <div class="col-span-4 px-8">
      <h3 class="text-xl font-bold">
        Bilet Fiyatları
      </h3>
      <hr>
      <ul>
        <li>
          <span class="font-bold">6.kategori</span>: 266.00 TL
        </li>
        <li>
          <span class="font-bold">6.kategori</span>: 266.00 TL
        </li>
        <li>
          <span class="font-bold">6.kategori</span>: 266.00 TL
        </li>
      </ul>
    </div>
    <div class="col-span-4 px-8">
      <ActivitySlider/>
    </div>
  </div>
</template>

<script setup>
import ActivitySlider from '@/components/ui/ActivitySlider.vue';
</script>

<style>

</style>
