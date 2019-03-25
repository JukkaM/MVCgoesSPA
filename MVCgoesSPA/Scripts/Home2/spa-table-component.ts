import Vue from "vue";
import { Component, Prop } from "vue-property-decorator";
import axios from "axios";
import { Spa, Visitor } from "./models";
import VueTables from "vue-tables-2";

@Component({
})
export default class SpaTableComponent extends Vue {

    tableData: any = [];
    rawData: Spa[];
    isBusy: boolean = true;

    mounted(): void {
        axios.get<Spa[]>("/api/homeapi").then((result) => {
            this.rawData = result.data;
            this.tableData = [];
            result.data.forEach((value, index) => {
                this.tableData.push({
                    name: value.Name,
                    day_price: value.DayTicketPrice,
                    weekend_price: value.WeekEndTicketPrice,
                    number_of_visitors: value.Visitors.length
                });
                this.isBusy = false;
            });

        });
    }

    rowSelected(rows: any) {
        console.log(rows);
    }
}