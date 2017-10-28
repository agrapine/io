import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Gallery extends React.Component<RouteComponentProps<{}>, {}>{
  render() {
    return <div>
      <p>personal gallery</p>
    </div>;
  }
}