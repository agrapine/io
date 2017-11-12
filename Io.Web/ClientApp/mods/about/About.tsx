import * as React from 'react';
import * as ui from 'material-ui';
import { RouteComponentProps } from 'react-router';

export class About extends React.Component<RouteComponentProps<{}>, {}>{
  render() {
    return <div style={{ margin: '2em' }}>
      <ui.Typography type='headline'>about</ui.Typography>
      <ui.Typography type='subheading'>what were you hopping to find...?</ui.Typography>
    </div>
  }
}