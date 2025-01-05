import { createAsyncThunk, createSlice, isAnyOf } from "@reduxjs/toolkit";
import { User } from "../../types/use";
import { login, currentUser, register } from "../../api/acount";
import { message } from "antd";


interface AccountState {
  user: User | null;
  errors:{error:[]}
}

const initialState: AccountState = {
  user: null,
  errors:{error:[]}
};

export const signInUser = createAsyncThunk<User, User>(
  "account/signInUser",
  async (_, thunkAPI) => {
    try {
      const { data } = await login(_);
      if (data) message.success("login success!");
      return data;
    } catch (err) {
      return thunkAPI.rejectWithValue({ error: err });
    }
  }
);

export const fetchCurrentUser = createAsyncThunk<User, { data: any }>(
  "account/fetchCurrentUser",
  async (_, thunkAPI) => {
    const { data: User } = await currentUser();

    return User;
  }
);

export const registerUser = createAsyncThunk<User,User>(
  "account/registerUser",
  async (_, thunkAPI) => {
    try {
      const { data } = await register(_);
      if (data) message.success("register success!");
      return data;
    } catch (err) {
      return thunkAPI.rejectWithValue({ error: err });
    }
  }
)

export const accountSlice = createSlice({
  name: "account",
  initialState,
  reducers: {
    signOut: (state) => {
      state.user = null;
    },
    signIn:(state,action)=>{
       state.user = action.payload
    }
  },
  extraReducers: (builder) => {
    builder
      .addMatcher(
        isAnyOf(signInUser.fulfilled, fetchCurrentUser.fulfilled,registerUser.fulfilled),
        (state, action) => {
          state.user = action.payload;
        }
      )
      .addMatcher(
        isAnyOf(signInUser.rejected, fetchCurrentUser.rejected,registerUser.rejected),
        (state, action) => {
          // state.errors = action.payload as {error:[]}
        }
      );
  },
});

export const { signOut,signIn } = accountSlice.actions;
