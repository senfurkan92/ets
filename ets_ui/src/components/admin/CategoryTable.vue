<template>
  <div>
    <div class="mb-8">
      <ModalBox :title="'Add Category'" :btnContent="'Add Category'">
        <CategoryForm/>
      </ModalBox>
    </div>
    <div class="mb-8 overflow-x-auto">
      <table class="table table-zebra w-full">
        <thead>
          <tr>
            <th>Title</th>
            <th class="text-center">#</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>Tarkan</td>
            <td class="text-center">
              <button class="btn btn-error">-</button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script setup>
import ModalBox from '@/components/ui/ModalBox.vue';
import CategoryForm from '@/components/admin/CategoryForm.vue';
</script>
