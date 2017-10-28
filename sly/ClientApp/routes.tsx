import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Gallery } from './components/Gallery';
import { About } from './components/About';

export const routes = <Layout>
    <Route exact path='/' component={ Gallery } />
    <Route path='/about' component={ About } />
</Layout>;
