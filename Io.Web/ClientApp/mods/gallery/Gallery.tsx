import * as React from 'React';
import { RouteComponentProps } from 'react-router';
import 'isomorphic-fetch';
import * as data from 'ClientApp/data';
import { PhotoCard } from './PhotoCard';
import * as ui from 'material-ui';

type GalleryProps =
  RouteComponentProps<{}>;

interface GalleryState {
  isLoading: boolean;
  showModal: boolean;
  modalUrl: string;
  photos: data.db.Photo[];
}

export class Gallery extends React.Component<GalleryProps, GalleryState>{

  state = {
    isLoading: true,
    modalUrl: '',
    showModal: false,
    photos: [],
  };

  componentDidMount() {
    this.loadGallery();
  }

  loadGallery = () => {
    fetch('api/gallery/photos')
      .then(response => response.json())
      .then(data => {
        this.setState({ isLoading: false, photos: data as data.db.Photo[] })
      });
  }

  onRequest = (index: number) => () => {
    const { photos } = this.state;
    console.log(photos[index]);
    this.setState({ showModal: true });
  }

  toggleModal = (show: boolean) => () => {
    console.log(show);
    this.setState({ showModal: show });
  }

  render() {
    const { photos, showModal, modalUrl } = this.state;
    return <div>
      <ui.Dialog fullScreen open={showModal} onRequestClose={this.toggleModal(false)}>
        <ui.DialogTitle>
          <ui.Typography>image.000.jpg</ui.Typography>
        </ui.DialogTitle>
        <ui.DialogContent>
          <p>test</p>
        </ui.DialogContent>
        <ui.DialogActions>
          <ui.Button onClick={this.toggleModal(false)}>close</ui.Button>
        </ui.DialogActions>
      </ui.Dialog>

      <ui.List>
        {photos.map((p, i) => <PhotoCard key={i} {...p} onRequest={this.onRequest(i)} />)}
      </ui.List>
    </div>;
  }
}
