import AboutUs from './components/AboutUs';
import Footer from './components/Footer';
import Header from './components/Header';
import Homepage from './components/Homepage';
import apiActions from './api/apiActions';

export default pageBuild

function pageBuild()
{
    header()
    homepage()
    footer()
    AboutUs()
}

function header()
{
    const header = document.querySelector('#header')
    header.innerHTML = Header()
}

function footer()
{
    const footer = document.querySelector('#footer')
    footer.innerHTML = Footer()
}

function homepage()
{
    const homepageButton = document.querySelector('#header')
    header.innerHTML = Header()
}