<template>
  <v-app>
    <v-container>
      <v-card>
        <Drawer :tables="tables" />
        <router-view :key="$route.fullPath" />
      </v-card>
    </v-container>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import api, { QueryNames } from "@/api";
import Drawer from "@/components/Drawer.vue";

export default Vue.extend({
  
  name: "App" as string,
  components: {
    Drawer,
  },
  mounted() {
    api.Query.getAllQueries()
      .then((resp) => (this.tables = resp.data))
      .catch((err) => console.log(err));
  },

  data: () => ({
    tables: {} as QueryNames,
  }),
});
</script>
