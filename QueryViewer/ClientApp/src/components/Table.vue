<template>
  <v-card>
    <v-card-title>
      <v-text-field
        v-model="search"
        append-icon="mdi-magnify"
        label="Search"
        single-line
        hide-details
      ></v-text-field>
    </v-card-title>
    <v-data-table
      :headers="headers"
      :items="rows"
      :footer-props="{
        showFirstLastPage: true,
        itemsPerPageOptions: [5, 10, 20],
        firstIcon: 'mdi-arrow-collapse-left',
        lastIcon: 'mdi-arrow-collapse-right',
      }"
      :search="search"
      class="elevation-1"
    ></v-data-table>
  </v-card>
</template>

<script lang="ts">
import Vue from "vue";
export default Vue.extend({
  props: ["headers", "rows"],
  data: () => ({
    search: '' as string,
  }),
});
</script>
