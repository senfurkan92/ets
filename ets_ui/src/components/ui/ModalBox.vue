<template>
<label for="my-modal" class="btn modal-button">{{props.btnContent || 'OPEN MODAL'}}</label>

<!-- Put this part before </body> tag -->
<input type="checkbox" id="my-modal" class="modal-toggle" />
<label for="my-modal" class="modal cursor-pointer">
  <label class="modal-box relative w-11/12 max-w-5xl" for="">
    <h3 class="text-lg font-bold">{{props.title || 'Modal'}}</h3>
    <div class="py-4">
        <slot/>
    </div>
  </label>
</label>
</template>

<script setup>
const props = defineProps({
  title: {
    type: String,
    required: true,
  },
  btnContent: {
    type: String,
    required: true,
  },
});

</script>
