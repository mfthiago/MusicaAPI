import produce from 'immer';
import types from './types';
const INITIAL_STATE = {
  clientes: [],
};

function cliente(state = INITIAL_STATE, action) {
  switch (action.type) {
    case types.UPDATE_CLIENTE: {
      console.log(action)
      return produce(state, (draft) => {
        draft = { ...draft, ...action.payload };
        return draft;
      });
    }

    case types.FILTER_CLIENTE: {
      return produce(state, (draft) => {
        draft.form.filtering = true;
        return draft;
      });
    }

    case types.RESET_CLIENTE: {
      return produce(state, (draft) => {
        draft.cliente = INITIAL_STATE.cliente;
        return draft;
      });
    }
    default:
      return state;
  }
}

export default cliente;