<template>
  <div class="navbar bg-info">
    <div class="navbar-start">
      <div class="dropdown">
        <label tabindex="0" class="btn btn-ghost lg:hidden">
          <svg
            xmlns="http://www.w3.org/2000/svg"
            class="h-5 w-5"
            fill="none"
            viewBox="0 0 24 24"
            stroke="currentColor"
          >
            <path
              stroke-linecap="round"
              stroke-linejoin="round"
              stroke-width="2"
              d="M4 6h16M4 12h8m-8 6h16"
            />
          </svg>
        </label>
        <ul
          tabindex="0"
          class="
            menu menu-compact
            dropdown-content
            mt-3
            p-2
            shadow
            bg-info
            rounded-box
            w-52
          "
        >
          <li class="text-info-content"><a>Item 1</a></li>
          <li class="text-info-content"><a>Item 2</a></li>
          <li class="text-info-content"><a>Item 3</a></li>
        </ul>
      </div>
      <a class="btn btn-ghost normal-case text-xl">daisyUI</a>
    </div>
    <div class="navbar-center hidden lg:flex">
      <ul class="menu menu-horizontal p-0">
        <li class="text-info-content link-item"><a class="link-item">Tiyatro</a></li>
        <li class="text-info-content link-item"><a class="link-item">Sinema</a></li>
        <li class="text-info-content link-item"><a class="link-item">Gezi</a></li>
      </ul>
    </div>
    <div class="navbar-end">
      <label class="swap swap-rotate">
        <!-- this hidden checkbox controls the state -->
        <input type="checkbox" @change="changeTheme" :checked="$store.state.theme === 'winter'"/>
        <!-- sun icon -->
        <svg
          class="swap-on fill-current w-10 h-10 text-base-100"
          xmlns="http://www.w3.org/2000/svg"
          viewBox="0 0 24 24"
        >
          <!-- eslint-disable max-len -->
          <path
            d="M5.64,17l-.71.71a1,1,0,0,0,0,1.41,1,1,0,0,0,1.41,0l.71-.71A1,1,0,0,0,5.64,17ZM5,12a1,1,0,0,0-1-1H3a1,1,0,0,0,0,2H4A1,1,0,0,0,5,12Zm7-7a1,1,0,0,0,1-1V3a1,1,0,0,0-2,0V4A1,1,0,0,0,12,5ZM5.64,7.05a1,1,0,0,0,.7.29,1,1,0,0,0,.71-.29,1,1,0,0,0,0-1.41l-.71-.71A1,1,0,0,0,4.93,6.34Zm12,.29a1,1,0,0,0,.7-.29l.71-.71a1,1,0,1,0-1.41-1.41L17,5.64a1,1,0,0,0,0,1.41A1,1,0,0,0,17.66,7.34ZM21,11H20a1,1,0,0,0,0,2h1a1,1,0,0,0,0-2Zm-9,8a1,1,0,0,0-1,1v1a1,1,0,0,0,2,0V20A1,1,0,0,0,12,19ZM18.36,17A1,1,0,0,0,17,18.36l.71.71a1,1,0,0,0,1.41,0,1,1,0,0,0,0-1.41ZM12,6.5A5.5,5.5,0,1,0,17.5,12,5.51,5.51,0,0,0,12,6.5Zm0,9A3.5,3.5,0,1,1,15.5,12,3.5,3.5,0,0,1,12,15.5Z"
          />
        </svg>

        <!-- moon icon -->
        <svg
          class="swap-off fill-current w-10 h-10 text-base-100"
          xmlns="http://www.w3.org/2000/svg"
          viewBox="0 0 24 24"
        >
          <!-- eslint-disable max-len -->
          <path
            d="M21.64,13a1,1,0,0,0-1.05-.14,8.05,8.05,0,0,1-3.37.73A8.15,8.15,0,0,1,9.08,5.49a8.59,8.59,0,0,1,.25-2A1,1,0,0,0,8,2.36,10.14,10.14,0,1,0,22,14.05,1,1,0,0,0,21.64,13Zm-9.5,6.69A8.14,8.14,0,0,1,7.08,5.22v.27A10.15,10.15,0,0,0,17.22,15.63a9.79,9.79,0,0,0,2.1-.22A8.11,8.11,0,0,1,12.14,19.73Z"
          />
        </svg>
      </label>
    </div>
  </div>
</template>

<script setup>
import { useStore } from 'vuex';

const store = useStore();

const changeTheme = (e) => {
  const day = e.target.checked;
  store.commit('changeTheme', day ? 'winter' : 'night');
};
</script>

<style scoped>
.link-item {
  background: transparent;
}

.link-item:hover {
  font-weight: 500;
}

.link-item::before {
  content: "";
  width: 0;
  transform: rotateZ(-120deg);
  height: 1.5px;
  background: black;
  position: absolute;
  top: 44px;
  left: 7px;
  transition: 0.3s;
  transform-origin: left;
}

.link-item:hover::before {
  width: 35px;
  transform: rotateZ(-80deg);
}

.link-item::after {
  content: "";
  width: 100%;
  transform: scale(0, 0) rotateZ(0);
  height: 1.5px;
  background: black;
  position: absolute;
  top: 35px;
  left: 0;
  transition: 0.3s;
  transform-origin: right;
}

.link-item:hover::after {
  transform: scale(1, 1) rotateZ(-2deg);
}
</style>
