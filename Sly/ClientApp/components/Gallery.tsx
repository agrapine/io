import * as React from 'react';

export class Gallery extends React.Component<{}, GalleryState> {
  constructor() {
    super();
    this.state = { isLoading: true, photos: [] };
    this.loadGallery();
  }

  loadGallery() {
    var photos = fetch('api/gallery/photos').then(r => r.json()).then(data => {
      const photos = data as Photo[];
      this.setState({ isLoading: false, photos });
    });
  };

  public render() {
    const { photos } = this.state;
    return <div style={{display: 'flex'}}>
      <div style={{ display: 'flex', flexWrap: 'wrap', alignItems: 'center', alignContent: 'space-around', justifyContent: 'center' }}>
        {photos.map((p, i) => <Card key={i} photo={p} />)}
      </div>
    </div>;
  }
}

class Card extends React.Component<CardProps, {}> {
  render() {
    const { photo } = this.props;
    return <a href={photo.imageUrl}>
      <div style={{ display: 'flex', background: '#222', margin: '4px', padding: '8px' }}>
          <img src={photo.thumbUrl} style={{ margin: 'auto', width: '128px', height: '128px', objectFit: 'cover' }} />
      </div>
    </a>;
  }
}

interface GalleryState {
  isLoading: boolean;
  photos: Photo[];
}

interface Photo {
  title: string;
  description: string;
  thumbUrl: string;
  imageUrl: string;
}

interface CardProps {
  photo: Photo;
}