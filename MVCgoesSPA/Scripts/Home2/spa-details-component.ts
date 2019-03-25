import Vue from "vue";
import { Component, Prop } from "vue-property-decorator";
import axios from "axios";
import { Spa, Visitor } from "./models";

@Component({
})
export default class SpaTableComponent extends Vue {

    @Prop()
    id: number;

    data: Spa;
    isBusy: boolean = true;

    mounted(): void {
        
        axios.get<Spa>("/api/homeapi/" + this.id).then((result) => {
            this.data = result.data;
            this.isBusy = false;
        });
    }

    rowSelected(rows: any) {
        console.log(rows);
    }
}