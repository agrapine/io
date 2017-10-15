import './css/site.css';
import 'bootstrap';
import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { App } from './components/App';

function renderApp() {
    ReactDOM.render(<App/>, document.getElementById('react-app'));
}

renderApp();
