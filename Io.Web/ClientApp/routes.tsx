import * as React from 'react';
import { Route } from 'react-router-dom';
import * as mods from './mods';

export const routes = <mods.shell.Layout>
    <Route exact path='/' component={ mods.gallery.Gallery } />
    <Route path='/about' component={ mods.about.About } />
</mods.shell.Layout>;
