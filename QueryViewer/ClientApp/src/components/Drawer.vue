<template>
  <v-card>
    <v-navigation-drawer permanent width="100%">
      <v-list>
        <v-list-item link href="mailto:diogo.rodcarreira@hotmail.com">
          <v-list-item-content>
            <v-list-item-title class="title">
              Diogo Carreira
            </v-list-item-title>
            <v-list-item-subtitle
              >diogo.rodcarreira@hotmail.com</v-list-item-subtitle
            >
          </v-list-item-content>
        </v-list-item>
      </v-list>

      <v-divider></v-divider>

      <v-list-item-group v-model="selected" color="primary">
        <v-subheader>TABLES</v-subheader>
        <v-list-item v-for="(table, i) in tables" :key="i" :to="(i + 1).toString()">
          <v-list-item-icon>
            <v-icon>mdi-database-search</v-icon>
          </v-list-item-icon>
          <v-list-item-title>{{ table }}</v-list-item-title>
        </v-list-item>
      </v-list-item-group>
    </v-navigation-drawer>
  </v-card>
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({
  name: "Drawer",
  props: ["tables"],

  mounted() {
    this.selected = +this.$route.params.id - 1;
  },
  data: () => ({
    selected: 0 as number
  }),
});

</script>