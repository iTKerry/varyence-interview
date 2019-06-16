const requestGeolocationCoordinatesType = 'REQUEST_WEATHER_FORECASTS';
const receiveGeolocationCoordinatesType = 'RECEIVE_WEATHER_FORECASTS';
const initialState = { coordinates: [], isLoading: false };

export const actionCreators = {
  requestGeolocationCoordinates: address => async (dispatch, getState) => {
    if (address === getState().geolocationCoordinates.address) {
      return;
    }

    dispatch({ type: requestGeolocationCoordinatesType, address: address });

    const url = `api/geolocation/getcoordinates?address=${address}`;
    const response = await fetch(url);
    const coordinates = await response.json();

    dispatch({ type: receiveGeolocationCoordinatesType, address: address, coordinates });
  }
};

export const reducer = (state, action) => {
  state = state || initialState;

  if (action.type === requestGeolocationCoordinatesType) {
    return {
      ...state,
      address: action.address,
      isLoading: true
    };
  }

  if (action.type === receiveGeolocationCoordinatesType) {
    return {
      ...state,
      address: action.address,
      coordinates: action.coordinates,
      isLoading: false
    };
  }

  return state;
};
