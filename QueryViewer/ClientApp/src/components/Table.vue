<template>
  <v-data-table
    :headers="headers"
    :items="rows"
    :items-per-page="4"
    class="elevation-1"
  ></v-data-table>
</template>

<script lang="ts">
import Vue from "vue";
export default Vue.extend({
  props: ["headers", "rows"], 
  data: () => ({
    //headers: [],
    //rows: [],
  }),
});
</script>
