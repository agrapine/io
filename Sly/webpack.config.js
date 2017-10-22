const path = require('path');
const uglify = require('uglifyjs-webpack-plugin');

module.exports = {
  entry: ['babel-polyfill', './ClientApp/boot'],
  output: {
    path: path.resolve(__dirname, 'wwwroot/dist'),
    filename: 'main.js',
  },
  module: {
    rules: [
      {
        test: /\.tsx?$/,
        exclude: '/node_modules/',
        use: [
          {
            loader: 'babel-loader',
            options: {
              presets: ['env']
            }
          },
          {
            loader: 'ts-loader'
          }
        ],
      }
    ]
  },
  resolve: {
    extensions: ['.ts', '.tsx', '.js', '.jsx', '.d.ts'],
  },
  plugins: [
    new uglify()
  ]
}
