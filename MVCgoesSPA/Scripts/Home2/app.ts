import Vue from "vue";
import LayoutComponent from "./layout-component.vue";
import BootstrapVue from "bootstrap-vue";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap-vue/dist/bootstrap-vue.css";

Vue.use(BootstrapVue);

new Vue({
    el: "#root",
    components: {
        LayoutComponent
    }
});