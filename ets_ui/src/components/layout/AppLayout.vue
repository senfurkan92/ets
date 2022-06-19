<template>
  <div class="wrapper" :data-theme="$store.state.theme">
    <slot name="header" />
    <slot name="main" />
    <slot name="footer" />
  </div>
</template>

<style scoped>
.wrapper {
  display: grid;
  grid-template-rows: max-content auto max-content;
  min-height: 100vh;
}
</style>
