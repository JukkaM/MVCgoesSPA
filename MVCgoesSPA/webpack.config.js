const path = require('path');
const webpack = require('webpack');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');
const { CheckerPlugin } = require('awesome-typescript-loader');
const VueLoaderPlugin = require('vue-loader/lib/plugin');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

module.exports = (env, argv) => {
    const isDevBuild = !(env && env.prod);
    
    return {
        watch: false,
        mode: isDevBuild ? "development" : "production",
        entry: {
            "home2": "./Scripts/Home2/app.ts"
        },
        module: {
            rules: [
                {
                    test: /\.ts$/,
                    loader: 'awesome-typescript-loader',
                    exclude: /node_modules/,
                    options: {
                    }
                },
                {
                    test: /\.vue$/,
                    use: [
                        "vue-loader"
                    ]
                },
                {
                    test: /\.css$/,
                    use: [
                        {
                            loader: MiniCssExtractPlugin.loader,
                            options: {
                            }
                        }, 'css-loader']
                },
                {
                    test: /\.scss$/,
                    use: [{
                        loader: MiniCssExtractPlugin.loader,
                        options: {
                        }
                    }, 'css-loader', 'sass-loader'] }
            ]
        },
        resolve: {
            extensions: ['.ts', '.js', '.vue', '.json'],
            alias: {
                'vue$': 'vue/dist/vue.esm.js'
            }
        },
        output: {
            filename: '[name].js',
            path: path.resolve(__dirname, 'dist'),
            publicPath: isDevBuild ? 'http://localhost:3001/' : "/"
        },
        plugins: [
            new VueLoaderPlugin(),
            new webpack.DefinePlugin({
                'process.env': {
                    NODE_ENV: JSON.stringify(isDevBuild ? 'development' : 'production')
                }
            }),
            new MiniCssExtractPlugin({
                // Options similar to the same options in webpackOptions.output
                // both options are optional
                filename: "[name].css",
                chunkFilename: "[id].css"
            })
        ].concat(isDevBuild ? [
            new CheckerPlugin(),
            new webpack.HotModuleReplacementPlugin(),
            new webpack.NamedModulesPlugin()
        ] : [
                new UglifyJsPlugin({
                    uglifyOptions: {
                        ecma: 5
                    }
                })
            ]),
        devtool: isDevBuild ? 'cheap-module-source-map' : "",
        devServer: {
            contentBase: path.join(__dirname),
            compress: true,
            port: 3001,
            headers: {
                'Access-Control-Allow-Origin': '*'
            },
            hot: true,
            inline: true,
            overlay: true,
            writeToDisk: true,
            public: "localhost:3001"
        }
    };

};
