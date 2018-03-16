import { GET_POST_SUCCESS, GET_POST_ERROR } from './blogConstants.jsx'

const initialState = {
    data: { currentPage: 0, totalPages: 0, pageSize: 0, records: [] },
    error: ''
}

export default function blog(state = initialState, action) {
    switch (action.type) {
        case GET_POST_SUCCESS:
            return { ...state, data: action.posts, error: '' }
        case GET_POST_ERROR:
            return { ...state, error: action.error }
        default:
            return state;
    }
}