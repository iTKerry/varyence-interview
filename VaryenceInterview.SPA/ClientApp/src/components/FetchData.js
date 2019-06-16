import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { actionCreators } from '../store/GeolocationCoordinates';

class FetchData extends Component {
  componentDidMount() {
    this.ensureDataFetched();
  }

  componentDidUpdate() {
    this.ensureDataFetched();
  }

  ensureDataFetched() {
    const address = this.props.match.params.address;
    this.props.requestGeolocationCoordinates(address);
  }

  render() {
    return (
      <div>
        <h1>Coordinates</h1>
        <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
        {renderSearchBar(this.props)}
        {renderCoordinates(this.props)}
        {renderButtons(this.props)}
      </div>
    );
  }
}

function renderSearchBar(props) {
  //TODO: Implement search bar with search text field
}

function renderCoordinates(props) {
  return (
    <table className='table table-striped'>
      <thead>
        <tr>
          <th>Lon</th>
          <th>Lat</th>
        </tr>
      </thead>
      <tbody>
        {props.coordinates.map(coordinate =>
          <tr key={coordinate.latitude}>
            <td>{coordinate.latitude}</td>
            <td>{coordinate.longitude}</td>
          </tr>
        )}
      </tbody>
    </table>
  );
}

function renderButtons(props) {
  const address = "";

  //TODO: Implement buttons!

  return <p className='clearfix text-center'>
    <Link className='btn btn-default pull-left' to={`/fetch-data/${address}`}>Previous</Link>
    {props.isLoading ? <span>Loading...</span> : []}
  </p>;
}

export default connect(
  state => state.geolocationCoordinates,
  dispatch => bindActionCreators(actionCreators, dispatch)
)(FetchData);
