<template>
    <div class="container">
        
        <div v-if="isBusy" class="text-center text-danger my-2">
            <b-spinner class="align-middle" />
            <strong>Loading...</strong>
        </div>
        <div v-if="!isBusy">
            <h1>{{data.Name}}</h1>

            <b-table striped hover :items="data.Visitors" />
        </div>
    </div>
</template>

<script lang="ts" src="./spa-details-component.ts"></script>