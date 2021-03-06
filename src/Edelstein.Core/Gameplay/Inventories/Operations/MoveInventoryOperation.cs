using Edelstein.Database.Entities.Inventories;
using Edelstein.Network.Packets;

namespace Edelstein.Core.Gameplay.Inventories.Operations
{
    public class MoveInventoryOperation : AbstractModifyInventoryOperation
    {
        protected override ModifyInventoryOperationType Type => ModifyInventoryOperationType.Move;
        public short ToSlot { get; }

        public MoveInventoryOperation(
            ItemInventoryType inventory,
            short slot,
            short toSlot
        ) : base(inventory, slot)
        {
            ToSlot = toSlot;
        }

        protected override void EncodeData(IPacket packet)
        {
            packet.Encode<short>(ToSlot);
        }
    }
}