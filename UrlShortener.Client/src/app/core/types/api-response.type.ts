export type ApiResponse<T = string> = {
  error?: {
    message: string;
  };
  data: T;
};
