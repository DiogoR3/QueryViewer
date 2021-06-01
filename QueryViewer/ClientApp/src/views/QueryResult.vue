<template>
  <div v-if="loaded">
    <Table :headers="result.headers" :rows="result.rows" />
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Table from "../components/Table.vue";
import api from "@/api";

export default Vue.extend({
  name: "QueryResult",

  data: () => ({
    loaded: false as boolean,
    result: { headers: [], rows: [] } as any,
  }),

  mounted() {
    const queryId = +this.$route.params.id || 0;

    api.Query.getQueryResult(queryId)
      .then((resp) => {
        this.result.headers = this.arrayToTextValue(resp.data.headers);
        this.result.rows = this.arrayToObject(resp.data.rows);
      })
      .catch((err) => console.log(err))
      .finally(() => this.loaded = true)
  },
  methods: {
    arrayToTextValue: function (array: any): any {
      let newArray = [];

      for (let [index, item] of array.entries())
        newArray.push({ text: item, value: index.toString() });

      return newArray;
    },
    arrayToObject(array: any): any {
      let newArray: any[] = [];

      for (let [outerIndex, outerItem] of array.entries()) {
        let newObj: any = {};
        for (let [innerIndex, innerItem] of outerItem.entries()) {
          newObj[innerIndex] = innerItem;
        }

        newArray.push(newObj);
      }

      return newArray;
    },
  },

  components: {
    Table,
  },
});

</script>