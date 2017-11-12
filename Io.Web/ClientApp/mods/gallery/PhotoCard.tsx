import * as React from "React";
import * as data from 'ClientApp/data';
import * as ui from 'material-ui';

type PhotoCardProps = data.db.Photo & {
  onRequest(): void;
}

export class PhotoCard extends React.Component<PhotoCardProps, {}> {
  render() {
    const { title, imageUrl, thumbUrl, onRequest } = this.props;
    return <ui.Button onClick={() => onRequest()} style={{ margin: 4, boxShadow: '0px 0px 6px #888', padding: 0 }}>
      <img src={thumbUrl} title={title} />
    </ui.Button>
  }
}