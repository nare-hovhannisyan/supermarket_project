import React from "react";
import Layout from "./Hoc/Layout.jsx";
import { Switch, Route } from "react-router-dom";
import Signin from "./Components/signin/index";
import Login from "./Components/login/index";
import Home from "./Components/home/index";
const Routes = props => {
  return (
    <Layout>
      <Switch>
        <Route exact path="/sign_form">
          <Signin />
        </Route>
        <Route exact path="/login_form">
          <Login />
        </Route>
        <Route exact path="/">
          <Home />
        </Route>
      </Switch>
    </Layout>
  );
};

export default Routes;
