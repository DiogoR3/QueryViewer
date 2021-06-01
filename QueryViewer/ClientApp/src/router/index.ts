import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'
import QueryResult from '../views/QueryResult.vue'

Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
  {
    path: '/',
    name: 'default',
    redirect: '/query/1'
  },
  {
    path: '/query/:id',
    name: 'QueryResult',
    component: QueryResult
  }
]

const router = new VueRouter({
  routes
})

export default router
