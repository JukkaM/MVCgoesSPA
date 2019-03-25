import Vue from "vue";
import { Component } from "vue-property-decorator";
import SpaTableComponent from "./spa-table-component.vue";

@Component({
    components: {
        SpaTableComponent
    }
})
export default class LayoutComponent extends Vue {

}