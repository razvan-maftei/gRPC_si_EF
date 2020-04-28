// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/PostComment.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PostCommentService {
  public static partial class PostCommentService
  {
    static readonly string __ServiceName = "PC.PostCommentService";

    static readonly grpc::Marshaller<global::PostCommentService.Post> __Marshaller_PC_Post = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PostCommentService.Post.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PostCommentService.Empty> __Marshaller_PC_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PostCommentService.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PostCommentService.id> __Marshaller_PC_id = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PostCommentService.id.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PostCommentService.Posts> __Marshaller_PC_Posts = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PostCommentService.Posts.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PostCommentService.Comment> __Marshaller_PC_Comment = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PostCommentService.Comment.Parser.ParseFrom);

    static readonly grpc::Method<global::PostCommentService.Post, global::PostCommentService.Empty> __Method_AddPost = new grpc::Method<global::PostCommentService.Post, global::PostCommentService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_PC_Post,
        __Marshaller_PC_Empty);

    static readonly grpc::Method<global::PostCommentService.Post, global::PostCommentService.Post> __Method_UpdatePost = new grpc::Method<global::PostCommentService.Post, global::PostCommentService.Post>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_PC_Post,
        __Marshaller_PC_Post);

    static readonly grpc::Method<global::PostCommentService.Post, global::PostCommentService.Empty> __Method_DeletePost = new grpc::Method<global::PostCommentService.Post, global::PostCommentService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_PC_Post,
        __Marshaller_PC_Empty);

    static readonly grpc::Method<global::PostCommentService.id, global::PostCommentService.Empty> __Method_GetPostById = new grpc::Method<global::PostCommentService.id, global::PostCommentService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_PC_id,
        __Marshaller_PC_Empty);

    static readonly grpc::Method<global::PostCommentService.Empty, global::PostCommentService.Posts> __Method_GetPosts = new grpc::Method<global::PostCommentService.Empty, global::PostCommentService.Posts>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPosts",
        __Marshaller_PC_Empty,
        __Marshaller_PC_Posts);

    static readonly grpc::Method<global::PostCommentService.Comment, global::PostCommentService.Empty> __Method_AddComment = new grpc::Method<global::PostCommentService.Comment, global::PostCommentService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddComment",
        __Marshaller_PC_Comment,
        __Marshaller_PC_Empty);

    static readonly grpc::Method<global::PostCommentService.Comment, global::PostCommentService.Comment> __Method_UpdateComment = new grpc::Method<global::PostCommentService.Comment, global::PostCommentService.Comment>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateComment",
        __Marshaller_PC_Comment,
        __Marshaller_PC_Comment);

    static readonly grpc::Method<global::PostCommentService.id, global::PostCommentService.Comment> __Method_GetcommentById = new grpc::Method<global::PostCommentService.id, global::PostCommentService.Comment>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetcommentById",
        __Marshaller_PC_id,
        __Marshaller_PC_Comment);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PostCommentService.PostCommentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PostCommentService</summary>
    [grpc::BindServiceMethod(typeof(PostCommentService), "BindService")]
    public abstract partial class PostCommentServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::PostCommentService.Empty> AddPost(global::PostCommentService.Post request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::PostCommentService.Post> UpdatePost(global::PostCommentService.Post request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::PostCommentService.Empty> DeletePost(global::PostCommentService.Post request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::PostCommentService.Empty> GetPostById(global::PostCommentService.id request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::PostCommentService.Posts> GetPosts(global::PostCommentService.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::PostCommentService.Empty> AddComment(global::PostCommentService.Comment request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::PostCommentService.Comment> UpdateComment(global::PostCommentService.Comment request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::PostCommentService.Comment> GetcommentById(global::PostCommentService.id request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PostCommentServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddPost, serviceImpl.AddPost)
          .AddMethod(__Method_UpdatePost, serviceImpl.UpdatePost)
          .AddMethod(__Method_DeletePost, serviceImpl.DeletePost)
          .AddMethod(__Method_GetPostById, serviceImpl.GetPostById)
          .AddMethod(__Method_GetPosts, serviceImpl.GetPosts)
          .AddMethod(__Method_AddComment, serviceImpl.AddComment)
          .AddMethod(__Method_UpdateComment, serviceImpl.UpdateComment)
          .AddMethod(__Method_GetcommentById, serviceImpl.GetcommentById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PostCommentServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddPost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PostCommentService.Post, global::PostCommentService.Empty>(serviceImpl.AddPost));
      serviceBinder.AddMethod(__Method_UpdatePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PostCommentService.Post, global::PostCommentService.Post>(serviceImpl.UpdatePost));
      serviceBinder.AddMethod(__Method_DeletePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PostCommentService.Post, global::PostCommentService.Empty>(serviceImpl.DeletePost));
      serviceBinder.AddMethod(__Method_GetPostById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PostCommentService.id, global::PostCommentService.Empty>(serviceImpl.GetPostById));
      serviceBinder.AddMethod(__Method_GetPosts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PostCommentService.Empty, global::PostCommentService.Posts>(serviceImpl.GetPosts));
      serviceBinder.AddMethod(__Method_AddComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PostCommentService.Comment, global::PostCommentService.Empty>(serviceImpl.AddComment));
      serviceBinder.AddMethod(__Method_UpdateComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PostCommentService.Comment, global::PostCommentService.Comment>(serviceImpl.UpdateComment));
      serviceBinder.AddMethod(__Method_GetcommentById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PostCommentService.id, global::PostCommentService.Comment>(serviceImpl.GetcommentById));
    }

  }
}
#endregion