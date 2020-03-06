import React, { Component } from "react";
import Appbar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
//import Button from "@material-ui/core/Button";
import Button from 'react-bootstrap/Button'
import { Link } from "react-router-dom";
import { SupMarketLogo } from "../ui/icons";
import SearchPage from "../Header_Footer/SearchPage";

class Header extends Component {
  constructor(props) {
    super(props)
    this.state = {
      hover: false
    }
    this.toggleHover = this.toggleHover.bind(this);
  }

  toggleHover() {
    this.setState({hover: !this.state.hover})
    
  }
  componentDidMount(){
      fetch('https://localhost:5001/Products')
      .then(response => response.json())
      .then(json => console.log(json))
  }

  render() {
    return (
      <Appbar
        position="fixed"
        style={{
          backgroundColor: "white",
          boxShadow: "none",
          padding: "8px 0",
          borderBottom: "2px solid #00285e",
          position: "fixed"
        }}
      >
        <Toolbar style={{ display: "flex" }}>
          <div style={{ flexGrow: 10 }}>
            <div className="header_logo">
              <SupMarketLogo
                link={true}
                linkTo="/"
                width="90px"
                height="75px"
                borderRadius="12px"

              />
            </div>
          </div>
          <div className = "search">
          <SearchPage className = "search"/>
          </div>
          
          <div className="wrapperDiv">
            <Button href="/all_products"  variant="outline-success" onMouseEnter={this.toggleHover} >Products</Button>
            </div>
            <div className="wrapperDiv">
            <Button href = "/login_form" variant="outline-success">Login</Button>
            </div>
            <div className="wrapperDiv">
            <Button href="/sign_form" variant="outline-primary">Signin</Button>
            </div>
        </Toolbar>
      </Appbar>
    );
  }
}

export default Header;
