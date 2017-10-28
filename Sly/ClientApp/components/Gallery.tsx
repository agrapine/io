import * as React from 'react';
import Card, { CardMedia, CardContent } from 'material-ui/Card';
import { Typography } from 'material-ui';

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
    return <div>
      <div style={{ margin: 8, padding: 8, display: 'flex', flexWrap: 'wrap' }}>
        {photos.map((p, i) => <GalleryCard key={i} photo={p} />)}
      </div>
    </div>;    
  }
}

class GalleryCard extends React.Component<CardProps, {}> {
  render() {
    const { photo } = this.props;
    return <div>
      <Card style={{ maxHeight: 400, margin: 8, width: 128 }}>
        <a href={photo.imageUrl}>
          <CardMedia image={photo.thumbUrl} title={photo.description} style={{ height: 128 }} />
        </a>
        <CardContent>
          <Typography>{photo.title}</Typography>
        </CardContent>
      </Card>
    </div>;
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