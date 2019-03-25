<template>
    <div class="container">
        <b-table selectable select-mode="single" striped hover :items="tableData" :busy="isBusy" @row-selected="rowSelected">
            <div slot="table-busy" class="text-center text-danger my-2">
                <b-spinner class="align-middle" />
                <strong>Loading...</strong>
            </div>
        </b-table>
    </div>
</template>

<script lang="ts" src="./spa-table-component.ts"></script>