import Vue from "vue";
import LayoutComponent from "./layout-component.vue";
import SpaTableComponent from "./spa-table-component.vue";
import SpaDetailsComponent from "./spa-details-component.vue";
import BootstrapVue from "bootstrap-vue";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap-vue/dist/bootstrap-vue.css";
import VueRouter from "vue-router";

Vue.use(BootstrapVue);
Vue.use(VueRouter);

const routes = [
    { path: '/', component: SpaTableComponent },
    { path: '/home', component: SpaTableComponent },
    { path: '/spa/:id', component: SpaDetailsComponent, props: true }
]

const router = new VueRouter({
    routes // short for `routes: routes`
})

new Vue({
    el: "#root",
    components: {
        LayoutComponent
    },
    router
});