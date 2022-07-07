/** @type {import('tailwindcss').Config} */

const defaultTheme = require('tailwindcss/defaultTheme');

module.exports = {
  prefix: 'tw-',
  content: [
    './src/app/**/*.{html,ts}'
    //"./src/**/*.{html,ts}",
  ],
  theme: {
    screens: {
       xs: '475px',
       ...defaultTheme.screens,
       '5xl': '1200px'
    },
    container:{
      color:true,
      padding:"1rem",
      screens:{
        lg: "1124px",
        xl: "1124px", "2xl": "1124px", 
      },
    },
    extend: {
      colors:{
        "orange":"#FFA91C",
        "red":"#FA5959",
        "blue": "#242A45",
        "grey": "#1914A2",
        "white": "#F7F7F7",
      }
    },
    backgroundImage:{
      'hero-pattern': "url('assets/cake-strawberry-cover.jpg')"
    }
  },
  plugins: [],
}
