<template>
  <div>
    <div class="mb-8">
      <ModalBox :title="'Add Acitivity'" :btnContent="'Add Acitivity'">
        <ActivityForm/>
      </ModalBox>
    </div>
    <div class="mb-8 overflow-x-auto">
      <table class="table table-zebra w-full">
        <thead>
          <tr>
            <th>Title</th>
            <th>Start Date</th>
            <th>End Date</th>
            <th>Poster</th>
            <th class="text-center">#</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>Tarkan</td>
            <td>6/20/2022 12:30pm</td>
            <td>8/20/2022 12:30pm</td>
            <td>
              <div class="h-40 aspect-[5/7]">
                <img
                  class="h-full w-full object-contain"
                  src="https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/a944da54063079.594ce3e22a882.jpg"
                  alt=""
                />
              </div>
            </td>
            <td class="text-center">
              <button class="btn btn-error">-</button>
            </td>
          </tr>
          <tr>
            <td>Tarkan</td>
            <td>6/20/2022 12:30pm</td>
            <td>8/20/2022 12:30pm</td>
            <td>
              <div class="h-40 aspect-[5/7]">
                <img
                  class="h-full w-full object-contain"
                  src="https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/a944da54063079.594ce3e22a882.jpg"
                  alt=""
                />
              </div>
            </td>
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
import ActivityForm from '@/components/admin/ActivityForm.vue';
</script>
