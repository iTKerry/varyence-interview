import React from 'react';
import { connect } from 'react-redux';

const Home = props => (
  <div>
    <h1>Hello, Varyence!</h1>
    <p>Welcome to my .NET Web Dev interview task!</p>
  </div>
);

export default connect()(Home);
