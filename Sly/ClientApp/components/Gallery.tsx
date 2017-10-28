import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import 'isomorphic-fetch';

export class Gallery extends React.Component<RouteComponentProps<{}>, GalleryState>{
  loadGallery = () => {
    fetch('api/gallery/photos')
      .then(response => response.json())
      .then(data => {
        this.setState({ isLoading: false, photos: data as Photo[] })
      });
  }

  constructor() {
    super();
    this.state = { isLoading: true, photos: [] };
    this.loadGallery();
  }

  render() {
    const { photos } = this.state;
    return <div style={{display:'flex', flexWrap:'wrap'}}>
      {photos.map((p, i) => <GalleryCard key={i} photo={p} />)}
    </div>;
  }
}

class GalleryCard extends React.Component<GalleryCardProps, {}>{
  render() {
    const {photo} = this.props;
    return <a href={photo.imageUrl}>
    <img style={{boxShadow:'0px 0px 6px #888', margin:4}} src={photo.thumbUrl} title={photo.title}/>
    </a>;
  }
}

interface GalleryState {
  isLoading: boolean;
  photos: Photo[],
}

interface Photo {
  title: string;
  description: string;
  thumbUrl: string;
  imageUrl: string;
}

interface GalleryCardProps {
  photo: Photo;
}