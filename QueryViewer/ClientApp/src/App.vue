<template>
  <v-app>
    <v-container fill-height fluid>
      <v-row :align="center" justify="center">
        <v-col cols="12" xs="8" sm="10" md="3" lg="2" xl="2">
          <Drawer :tables="tables" />
        </v-col>
        <v-col cols="12" xs="12" sm="12" md="9" lg="10" xl="10">
          <router-view :key="$route.fullPath" />
        </v-col>
      </v-row>
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
    center: "center" as string,
  }),
});
</script>
