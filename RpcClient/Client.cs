namespace RpcClient;

public class Client
{
    /*
     so there are multiple ways to open a channel for neovim and for msgpack rpc
     this class is the primary client that impls this spec: 
        https://github.com/MessagePack-CSharp/MessagePack-CSharp?tab=readme-ov-file#nuget-packages 
     

     */

    public Client(string host, int port)
    {
        //connect to host
    }

    //TODO abstract Call and CallAsync a bit so that they cant change to much
    //if one gets updatated vs the other
    public T? Call<T>(string methodName, params object[] args)
    {
        return default(T);
    }
    public async  Task<T?> CallAsync<T>(string methodName, params object[] args)
    {
        return await Task.FromResult(default(T));
    }
    
    
}