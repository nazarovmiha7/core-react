﻿import React from 'react'
import { render } from 'react-dom'
import { createStore, applyMiddleware } from 'redux'
import { Provider } from 'react-redux'
import thunk from 'redux-thunk'
import App from './containers/app.jsx'
import blogReducer from './containers/blog/blogReducer.jsx'

function configureStore(initialState) {
    return createStore(blogReducer, initialState, applyMiddleware(thunk))
}

const store = configureStore();

render(
    <Provider store={store}>
        <App />
    </Provider>,
    document.getElementById('content')
)