import * as React from 'React';
import * as ui from 'material-ui';
import MenuIcon from 'material-ui-icons/Menu';
import { NavLink } from 'react-router-dom';

export interface LayoutProps {
  children?: React.ReactNode;
}

export interface LayoutState {
  showDrawer: boolean;
}

export class Layout extends React.Component<LayoutProps, LayoutState> {

  state = {
    showDrawer: false
  }

  toggleDrawer = (show: boolean) => () => {
    this.setState({ showDrawer: show });
  }

  public render() {
    const { showDrawer } = this.state;
    return <div>
      <ui.AppBar position='static'>
        <ui.Toolbar>
          <ui.IconButton color='contrast' aria-label='Menu' onClick={this.toggleDrawer(true)}>
            <MenuIcon />
          </ui.IconButton>
          <ui.Typography type='title' color='inherit'>
            slideshow
          </ui.Typography>
        </ui.Toolbar>
      </ui.AppBar>
      <ui.Drawer open={showDrawer} onRequestClose={this.toggleDrawer(false)}>
        <div
          tabIndex={0}
          role='button'
          onClick={this.toggleDrawer(false)}
          onKeyDown={this.toggleDrawer(false)}>
          <ui.List>
            <NavLink to='/'>
              <ui.ListItem button>
                <ui.ListItemText primary='slideshow'></ui.ListItemText>
              </ui.ListItem>
            </NavLink>
            <NavLink to='/about'>
              <ui.ListItem button>
                <ui.ListItemText primary='about'></ui.ListItemText>
              </ui.ListItem>
            </NavLink>
          </ui.List>
        </div>
      </ui.Drawer>
      <div>
        {this.props.children}
      </div>
    </div>;
  }
}
