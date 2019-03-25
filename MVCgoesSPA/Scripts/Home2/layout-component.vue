<template>
    <div>
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container">
                <a class="navbar-brand" href="#">Application name</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item active">
                            <a class="nav-link" href="/#/Home">
                                Home
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
            
        </nav>
        <div class="container body-content">
            <div class="jumbotron">
                <h1>Generic spa listing site for demo purposes</h1>
            </div>
            
            <spa-table-component />
            <hr />
            <footer>
                <p>My SPA.NET Application</p>
            </footer>
        </div>
    </div>
</template>

<script lang="ts" src="./layout-component.ts"></script>

<style lang="scss">
    footer {
    background: #fafafa;
    }
</style>