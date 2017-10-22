import * as React from 'react';
import { render } from 'react-dom';
import { App } from './components/App';

function strap() {
    render(<App/>, document.getElementById('app'));
}

strap();
